// Count types in an array
'use strict'

let types = (s) => {
  types = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (i of s) {
    const t = typeof i;
    types[t]++;
  }
  s.push('string');
  return types;
  s.length;
};

require('../Tests/types.js')(types);
