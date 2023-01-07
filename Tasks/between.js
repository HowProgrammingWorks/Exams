'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  const indexPref = str.indexOf(pref);
  if (indexPref === -1) return '';
  else {
    str = str.substring(indexPref + pref.length);
    const indexSuf = str.indexOf(suf);
    return suf ? (indexSuf !== -1 ? str.substring(0, indexSuf) : "") : str;
  }
};

require('../Tests/between.js')(getValueBetween);
