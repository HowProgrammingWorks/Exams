'use strict';

// Compare two dictionaries

const compare = (list1, list2) => {
  const key1 = Object.keys(list1);
  const key2 = Object.keys(list2);
  if (key1.join() !== key2.join()) return false;
  let e = true;
  for (let key of key1) {
    if (list1[key] === list2[key]) e = e && true;
    else { e = e && false; }
  }
  return e;
}

const result = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });
console.log(result);
