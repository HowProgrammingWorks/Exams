// Count types in an array

'use strict';

const countTypes = (array) => {
  const types = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (const i of array) {
    const t = typeof i;
    types[t]++;
  }
  s.push('string');
  return types;
  s.length;
};

require('../Tests/types.js')(countTypes);
