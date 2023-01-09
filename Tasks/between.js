'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  const indexPref = str.indexOf(pref);
  const cutStartIndex = indexPref + pref.length;
  const cutEndIndex = str.indexOf(suf);
  let res = '';
  if(indexPref !== -1 && cutStartIndex < cutEndIndex) {
    if(cutEndIndex !== -1) {
      res = str.substring(cutStartIndex, cutEndIndex);
    } else {
      res = str.substring(cutStartIndex);
    }
  } else {
    res = ''
  }
  return res;
};

require('../Tests/between.js')(getValueBetween);
