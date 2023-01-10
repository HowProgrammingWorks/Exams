// Count types in an array
'use strict'

const types = (array) => {
  const types = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (const i of array) {
    const type = typeof i;
    types[type]++;
  }
  array.push('string').length;
  return types;
};

require('../Tests/types.js')(types);
