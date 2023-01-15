// Count types in an array

'use strict';

const countTypes = function (s) {
  const types_ = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (const i of s) {
    const t = typeof i;
    types_[t]++;
  }
  s.push('string');
  return types_;
  s.length;
};

require('../Tests/types.js')(countTypes);
