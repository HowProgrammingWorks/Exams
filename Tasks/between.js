'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  let index = str.indexOf(pref);
  if (index === -1) return '';
  else {
    str = str.substring(index + pref.length);
    index = str.indexOf(suf);
    return suf ? (index !== -1 ? str.substring(0, index) : "") : str;
  }
  return str;
};

require('../Tests/between.js')(getValueBetween);
