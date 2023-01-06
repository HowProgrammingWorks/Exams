// Compare two dictionaries

'use strict';

const compare = (dictionary1, dictionary2) => {
  const keys1 = Object.keys(dictionary1);
  const keys2 = Object.keys(dictionary2);
  if (keys1.join('-') !== keys2.join('-')) return false;
  for (const key of keys1) {
    if (dictionary1[key] !== dictionary2[key]) return false;
  }
  return true;
};

require('../Tests/compare.js')(compare);
