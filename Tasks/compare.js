// Compare two dictionaries
'use strict';

const compare = (first_values, second_values) => {
  const a = Object.keys(first_values);
  const b = Object.keys(second_values);
  if (a.join('-') !== b.join('-')) return false;
  let e = true;
  for (c of a) {
    if (first_values[c] === second_values[c]) e = e && true;
    else {
      e = e && false;
    }
  }
  return e;
};

const result = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });
console.log(result);
