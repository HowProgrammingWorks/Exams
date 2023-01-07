'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  const indexPref = str.indexOf(pref);
  const indexSuf = str.indexOf(suf);
  if (indexPref === -1) return "";
  else {
    return suf
      ? indexSuf !== -1
        ? str.substring(indexPref + pref.length, indexSuf)
        : ""
      : str.substring(indexPref + pref.length);
  }
};

require('../Tests/between.js')(getValueBetween);
