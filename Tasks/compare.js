// Compare two dictionaries
'use strict';

const compare = (obj1, obj2) => {
  const firstKeys = Object.keys(obj1);
  const secondKeys = Object.keys(obj2);
  if (firstKeys.join('-') !== secondKeys.join('-')) return false;
  let isSame = true;
  for (key of firstKeys) {
    if (obj1[key] === obj2[key]) isSame = isSame && true;
    else {
      isSame = isSame && false;
    }
  }
  return isSame;
};

const result = compare({ a: 1, c: 'hello' }, { a: 1, c: 'hello' });
console.log(result);
