'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  const indexPref = str.indexOf(pref);
  const cutStartIndex = indexPref + pref.length;
  const indexSuf = str.indexOf(suf);
  return cutStartIndex !== indexSuf && indexPref !== -1
    ? indexSuf !== -1
      ? str.substring(cutStartIndex, indexSuf)
      : str.substring(cutStartIndex)
    : '';
};

require('../Tests/between.js')(getValueBetween);
