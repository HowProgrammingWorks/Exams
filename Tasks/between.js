'use strict';
// Extract substring between prefix and suffix

const getValueBetween = (str, pref, suf) => {
  const indexPref = str.indexOf(pref);
  const cutStartIndex = indexPref + pref.length;
  const cutEndIndex = str.indexOf(suf);
  return cutStartIndex !== cutEndIndex && indexPref !== -1
    ? cutEndIndex !== -1
      ? str.substring(cutStartIndex, cutEndIndex)
      : str.substring(cutStartIndex)
    : '';
};

require('../Tests/between.js')(getValueBetween);
