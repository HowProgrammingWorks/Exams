'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  const indexPref = str.indexOf(pref);
  const indexSuf = str.indexOf(suf);
  return indexPref !== -1
    ? suf
      ? indexSuf !== -1
        ? str.substring(indexPref + pref.length, indexSuf)
        : ''
      : str.substring(indexPref + pref.length)
    : '';
};

require('../Tests/between.js')(getValueBetween);
