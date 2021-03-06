rm(list=ls(all=TRUE))
library(RODBC)
library(scales)
library(reshape2)
library(ggplot2)
library(plyr)
library(colorspace)
library(NlsyLinks)
includedRelationshipPaths <- c(2)
# includedRelationshipPaths <- c(1)

# dsArchive <- read.csv("./MicroscopicViews/CrosstabHistoryArchive.csv")
# # dsArchive <- dsArchive[, -3] #Drop RImplicit2004 column
# dsArchive$RFull <- NA_real_

oName <- "HeightZGenderAge"
oName_1 <- paste0(oName, "_1")
oName_2 <- paste0(oName, "_2")

startTime <- Sys.time()
sql <- "SELECT  [AlgorithmVersion],[Subject1Tag], [Subject2Tag], [SameGeneration], [RFull] FROM [NlsLinks].[Process].[tblRelatedValuesArchive]"
channel <- RODBC::odbcDriverConnect("driver={SQL Server};Server=Bee\\Bass; Database=NlsLinks; Uid=NlsyReadWrite; Pwd=nophi")
odbcGetInfo(channel)
ds <- sqlQuery(channel, sql, stringsAsFactors=F)
odbcCloseAll()
# colnames(dsRaw) # head(dsRaw)
# colnames(dsArchive)
# ds <- plyr::rbind.fill(ds, dsArchive)

versionNumbers <- sort(unique(ds$AlgorithmVersion))
dsProportionLinked <- data.frame(Version=versionNumbers, OfTotal=NA_integer_, OfDV=NA_integer_, ofDVSameGeneration=NA_integer_)

dsOutcomes <- read.csv(file="./ForDistribution/Outcomes/ExtraOutcomes79.csv", stringsAsFactors=F)

for( versionNumber in versionNumbers ) {
  dsSlice <- ds[ds$AlgorithmVersion==versionNumber, ]  
  dsSlice$R <- dsSlice$RFull
  linksNames <- c("RFull", "SameGeneration")
  dsLink <- CreatePairLinksSingleEntered(outcomeDataset=dsOutcomes, linksPairDataset=dsSlice, linksNames=linksNames, outcomeNames=oName)
  
  ofTotal <- mean(!is.na(dsLink$RFull)) 
  ofDV <- mean(!is.na(dsLink[!is.na(dsLink[, oName_1]) & !is.na(dsLink[, oName_2]), "RFull"])) 
  ofDVSameGeneration <- mean(!is.na(dsLink[!is.na(dsLink[, oName_1]) & !is.na(dsLink[, oName_2]) & !is.na(dsLink$SameGeneration) & dsLink$SameGeneration!=0, "RFull"])) 
  
  dsProportionLinked[dsProportionLinked$Version==versionNumber, c("OfTotal", "OfDV", "ofDVSameGeneration")] <- c(ofTotal, ofDV, ofDVSameGeneration)
}
(elapsed <- Sys.time() - startTime)


dsProportionLinkedLong <- reshape2::melt(dsProportionLinked, id.vars="Version")
dsProportionLinkedLong <- plyr::rename(dsProportionLinkedLong, replace=c("variable"="Variable", "value"="Value"))

g <- ggplot(dsProportionLinkedLong, aes(x=Version, y=Value, color=Variable, shape=Variable)) +
  geom_line(alpha=.7) +
  geom_point(alpha=.7) +
  scale_color_brewer(type="qual") +
  scale_y_continuous(name="Percent Linked", labels=percent) +
  coord_cartesian(ylim=c(.85, 1)) + 
  theme_bw() + 
  theme(legend.position = c(1, 0), legend.justification=c(1,0))
  #theme(legend.position = "none") 
# g
ggsave(filename="./MicroscopicViews/VersionComparison/ProportionLinked.png", plot=g)
