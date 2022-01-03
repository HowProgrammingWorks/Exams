// Compare two dictionaries
'use strict';

const compare = (obj1, obj2) => {
  const firstKeys = Object.keys(obj1).sort();
  const secondKeys = Object.keys(obj2).sort();
  if (firstKeys.join('-') !== secondKeys.join('-')) return false;
  for (const key of firstKeys) {
    if (obj1[key] !== obj2[key]) return false;
  }
  return true;
};

const result = compare({ a: 1, c: 'hello' }, { c: 'hello', a: 1 });
console.log(result);
