'use strict';

// Compare two dictionaries

let compare = (list1, list2) => {
  let a = Object.keys(list1);
  let b = Object.keys(list2);
  if (a.join('-') !== b.join('-')) return false;
  let e = true;
  for (let c of a) {
    if (list1[c] === list2[c]) e = e && true;
    else { e = e && false; }
  }
  return e;
}

const result = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });
console.log(result);
