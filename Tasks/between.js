'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  let index = str.indexOf(pref);
  if (index === -1) return '';
  else {
    const start = index + pref.length;
    str = str.substring(start);
    if (suf) {
      index = str.indexOf(suf);
      if (index === -1) {
        return '';
      } else {
        str = str.substring(0, index);
      }
    }
  }
  return str;
};

require('../Tests/between.js')(getValueBetween);
