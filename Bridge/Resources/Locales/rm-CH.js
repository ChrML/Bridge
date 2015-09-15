﻿Bridge.merge(new Bridge.CultureInfo("rm-CH", true), {
    englishName: "Romansh (Switzerland)",
    nativeName: "Rumantsch (Svizra)",

    numberFormat: Bridge.merge(new Bridge.NumberFormatInfo(), {
        naNSymbol: "betg def.",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "-infinit",
        positiveInfinitySymbol: "+infinit",
        percentSymbol: "%",
        percentGroupSizes: [3],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ".",
        percentGroupSeparator: "'",
        percentPositivePattern: 1,
        percentNegativePattern: 1,
        currencySymbol: "fr.",
        currencyGroupSizes: [3],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ".",
        currencyGroupSeparator: "'",
        currencyNegativePattern: 2,
        currencyPositivePattern: 2,
        numberGroupSizes: [3],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ".",
        numberGroupSeparator: "'",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new Bridge.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["du","gli","ma","me","gie","ve","so"],
        abbreviatedMonthGenitiveNames: ["da schan.","da favr.","da mars","d'avr.","da matg","da zercl.","da fan.","d'avust","da sett.","d'oct.","da nov.","da dec.",""],
        abbreviatedMonthNames: ["schan.","favr.","mars","avr.","matg","zercl.","fan.","avust","sett.","oct.","nov.","dec.",""],
        amDesignator: "",
        dateSeparator: "-",
        dayNames: ["dumengia","glindesdi","mardi","mesemna","gievgia","venderdi","sonda"],
        firstDayOfWeek: 1,
        fullDateTimePattern: "dddd, 'ils’' d. MMMM, yyyy HH:mm:ss",
        longDatePattern: "dddd, 'ils’' d. MMMM, yyyy",
        longTimePattern: "HH:mm:ss",
        monthDayPattern: "d MMMM",
        monthGenitiveNames: ["da schaner","da favrer","da mars","d'avrigl","da matg","da zercladur","da fanadur","d'avust","da settember","d'october","da november","da december",""],
        monthNames: ["schaner","favrer","mars","avrigl","matg","zercladur","fanadur","avust","settember","october","november","december",""],
        pmDesignator: "",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "dd-MM-yyyy",
        shortestDayNames: ["du","gli","ma","me","gie","ve","so"],
        shortTimePattern: "HH:mm",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
