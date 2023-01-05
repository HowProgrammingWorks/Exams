// Compare two dictionaries

'use strict';

const compare = (first_values, ...parameters_LIST) => {
  const second_values = parameters_LIST[0];
  const a = Object.keys(first_values);
  const b = Object.keys(second_values);
  if (a.join('-') !== b.join('-')) return false;
  let e = true;
  for (const c of a) {
    if (first_values[c] === second_values[c]) e = e && true;
    else {
      e = e && false;
    }
  }
  return e;
};

require('../Tests/compare.js')(compare);
