// Count types in an array
'use strict'

const types = (array) => {
  const resObj = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (const item of array) {
    const type = typeof item;
    resObj[type]++;
  }
  return resObj;
};

require('../Tests/types.js')(types);
