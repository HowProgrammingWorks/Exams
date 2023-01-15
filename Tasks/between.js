'use strict';

const getValueBetween = (str, pref, suff) => {
  const indexPref = str.indexOf(pref);
  const indexSuff = str.indexOf(suff);
  if (indexPref === -1) return '';
  else {
    str = str.substring(indexPref + pref.length);
    return (suff ? (indexSuff === -1 ? '' : str.substring(0, indexSuff)) : str);
  }
};

require('../Tests/between.js')(getvaluebetween);
