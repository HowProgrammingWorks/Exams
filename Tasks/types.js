// Count types in an array

'use strict';

const countTypes = (array) => {
  const types = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (const item of array) {
    const type = typeof item;
    types[type]++;
  }
  return types;
};

require('../Tests/types.js')(countTypes);
