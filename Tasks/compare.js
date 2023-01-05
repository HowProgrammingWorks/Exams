// Compare two dictionaries

'use strict';

const compare = (dictionary1, ...args) => {
  const dictionary2 = args[0];
  const firstKeys = Object.keys(dictionary1);
  const secondKeys = Object.keys(dictionary2);
  if (firstKeys.join('-') !== secondKeys.join('-')) return false;
  let res = true;
  for (const key of firstKeys) {
    if (dictionary1[key] === dictionary2[key]) res = res && true;
    else {
      res = res && false;
    }
  }
  return res;
};

require('../Tests/compare.js')(compare);
