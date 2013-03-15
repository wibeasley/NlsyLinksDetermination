﻿using System;
namespace Nls.BaseAssembly {
	public enum MarkerType : byte {
		RosterGen1 = 1,
		ShareBiomom = 2,
		ShareBiodad = 3,
		DobSeparation = 5,
		GenderAgreement = 6,
		FatherAsthma = 10,
		BabyDaddyAsthma = 11,
		BabyDaddyLeftHHDate = 12,
		BabyDaddyDeathDate = 13,
		BabyDaddyAlive = 14,
		BabyDaddyInHH = 15,
		BabyDaddyDistanceFromHH = 16,
		Gen2CFatherAlive = 17,
		Gen2CFatherInHH = 18,
		Gen2CFatherDistanceFromHH = 19,
	}
	public enum Item : short {
		IDOfOther1979RosterGen1 = 1,
		RosterGen1979 = 2,
		SiblingNumberFrom1993SiblingRoster = 3,
		IDCodeOfOtherSiblingGen1 = 4,
		ShareBiomomGen1 = 5,
		ShareBiodadGen1 = 6,
		IDCodeOfOtherInterviewedBiodadGen2 = 9,
		ShareBiodadGen2 = 10,
		Gen1MomOfGen2Subject = 11,
		DateOfBirthMonth = 13,
		DateOfBirthYearGen1 = 14,
		DateOfBirthYearGen2 = 15,
		AgeAtInterviewDateYears = 16,
		AgeAtInterviewDateMonths = 17,
		InterviewDateDay = 20,
		InterviewDateMonth = 21,
		InterviewDateYear = 22,
		Gen1SiblingIsATwinOrTrip1994 = 25,
		Gen1MultipleSiblingType1994 = 26,
		Gen1ListedTwinCorrect1994 = 27,
		Gen1TwinIsMzOrDz1994 = 28,
		Gen1ListedTripCorrect1994 = 29,
		Gen1TripIsMzOrDz1994 = 30,
		MotherOrBothInHHGen2 = 37,
		FatherHasAsthmaGen2 = 40,
		BioKidCountGen1 = 48,
		Gen1ChildsIDByBirthOrder = 49,
		HerTwinsTripsAreListed = 50,
		HerTwinsAreMz = 52,
		HerTripsAreMz = 53,
		HerTwinsMistakenForEachOther = 54,
		HerTripsMistakenForEachOther = 55,
		BirthOrderInNlsGen2 = 60,
		SiblingCountTotalFen1 = 63,
		BioKidCountGen2 = 64,
		OlderSiblingsTotalCountGen1 = 66,
		Gen1HairColor = 70,
		Gen1EyeColor = 71,
		Gen2HairColor_NOTUSED = 72,
		Gen2EyeColor_NOTUSED = 73,
		BabyDaddyInHH = 81,
		BabyDaddyAlive = 82,
		BabyDaddyEverLiveInHH = 83,
		BabyDaddyLeftHHMonth = 84,
		BabyDaddyLeftHHYearFourDigit = 85,
		BabyDaddyDeathMonth = 86,
		BabyDaddyDeathYearTwoDigit = 87,
		BabyDaddyDeathYearFourDigit = 88,
		BabyDaddyDistanceFromMotherFuzzyCeiling = 89,
		BabyDaddyHasAsthma = 90,
		BabyDaddyLeftHHMonthOrNeverInHH = 91,
		BabyDaddyLeftHHYearTwoDigit = 92,
		SubjectID = 100,
		ExtendedFamilyID = 101,
		Gender = 102,
		Gen2CFatherLivingInHH = 121,
		Gen2CFatherAlive = 122,
		Gen2CFatherDistanceFromMotherFuzzyCeiling = 123,
		Gen2CFatherAsthma_NOTUSED = 125,
		Gen2YAFatherInHH_NOTUSED = 141,
		Gen2YAFatherAlive_NOTUSED = 142,
		Gen2YADeathMonth = 143,
		Gen2YADeathYearFourDigit = 144,
		Gen1HeightInches = 200,
		Gen1WeightPounds = 201,
		Gen1AfqtScaled2Decimals_NOTUSED = 202,
		Gen1AfqtScaled5Decimals = 203,
		Gen1FatherAlive = 300,
		Gen1FatherDeathCause = 301,
		Gen1FatherDeathAge = 302,
		Gen1FatherHasHealthProblems = 303,
		Gen1FatherHealthProblem = 304,
		Gen1FatherBirthCountry = 305,
		Gen1LivedWithFatherAtAgeX = 306,
		Gen1FatherHighestGrade = 307,
		Gen1GrandfatherBirthCountry = 308,
		Gen1MotherAlive = 320,
		Gen1MotherDeathCause = 321,
		Gen1MotherDeathAge = 322,
		Gen1MotherHasHealthProblems = 323,
		Gen1MotherHealthProblem = 324,
		Gen1MotherBirthCountry = 325,
		Gen1LivedWithMotherAtAgeX = 326,
		Gen1MotherHighestGrade = 327,
		Gen2HeightInchesTotal = 500,
		Gen2HeightFeetOnly = 501,
		Gen2HeightInchesRemainder = 502,
		Gen2HeightInchesTotalMotherSupplement = 503,
		Gen1ListIncorrectGen2TwinTrips_NOTINTAGCURRENTLY = 9993,
		Gen1VerifyFirstGen2TwinsTrips_NOTINTAGSETCURRENTLY = 9994,
		Gen1FirstIncorrectTwinTripYoungerOrOlder_NOTUSED = 9995,
		Gen1FirstIncorrectTwinTripAgeDifference_NOTUSED = 9996,
		Gen1SecondIncorrectTwinTripYoungerOrOlder_NOTUSED = 9997,
		Gen1SecondIncorrectTwinTripAgeDifference_NOTUSED = 9998,
		NotTranslated = 9999,  
		//Gen2YInHHGen1 = 81,
		//Gen2YAliveGen1 = 82,
		//Gen2YEverLiveInHH = 83,
		//Gen2YLeftHHMonth = 84,
		//Gen2YLeftHHYearFourDigit = 85,
		//Gen2YDeathMonth = 86,
		//Gen2YDeathYearTwoDigit = 87,
		//Gen2YDeathYearFourDigit = 88,
		//Gen2YDistanceFromMotherFuzzyCeiling = 89,
		//Gen2YHasAsthmaGen1 = 90,
		//Gen2YLeftHHMonthOrNeverInHH = 91,
		//Gen2YLeftHHYearTwoDigit = 92,
	}
	public enum ExtractSource : byte {
		Gen1Links = 3,
		Gen2Links = 4,
		Gen2LinksFromGen1 = 5,
		Gen2ImplicitFather = 6,
		Gen2FatherFromGen1 = 7,
		Gen1Outcomes = 8,
		Gen2OutcomesHeight = 9,
		Gen1Explicit = 10,
		Gen1Implicit = 11, 
	}
	public enum SurveySource : byte {
		NoInterview = 0,
		Gen1 = 1,
		Gen2C = 2,
		Gen2YA = 3,
	}
	public enum Generation : byte {
		Gen1 = 1,
		Gen2 = 2,
	}
	public enum MultipleBirth : byte {// 'Keep these values sync'ed with tblLUMultipleBirth in the database.
		No = 0,
		Twin = 2,
		Trip = 3,
		TwinOrTrip = 4, //Currently Then Gen1 algorithm doesn't distinguish.
		DoNotKnow = 255,
	}
	public enum Tristate : byte {
		No = 0,
		Yes = 1,
		DoNotKnow = 255,
	}
	public enum MultipleBirthImportGen1MzDistinction : byte {
		No = 0,
		Twin = 1,
		Trip = 2,
		TwinOrTrip = 3,
		DontKnow = 255,
	}
	public enum Gender : byte {
		Male = 1,
		Female = 2,
		InvalidSkipGen2 = 255,
	}
	public enum MarkerEvidence : byte {
		Irrelevant = 0,
		StronglySupports = 1,
		Supports = 2,
		Consistent = 3,
		Ambiguous = 4,
		Missing = 5,
		Unlikely = 6,
		Disconfirms = 7,
	}
	public enum RelationshipPath : byte {
		Gen1Housemates = 1,
		Gen2Siblings = 2,
		Gen2Cousins = 3,
		ParentChild = 4,
		AuntNiece = 5, //Acutally (Uncle|Aunt)-(Nephew|Niece)
	}
	public enum YesNo : short {
		ValidSkipOrNoInterviewOrNotInSurvey = -6,
		InvalidSkip = -3,
		DoNotKnow = -2,
		Refusal = -1,
		No = 0,
		Yes = 1,
	}
}
//public enum EverSharedHouse : byte {
//   No = 0,
//   Yes = 1,
//   //DontKnow = 255
//}
