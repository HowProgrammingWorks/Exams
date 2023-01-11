// Count types in an array
'use strict'

const types = (array) => {
  const result = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (const item of array) {
    const type = typeof item;
    result[type]++;
  }
  return result;
};

require('../Tests/types.js')(types);
