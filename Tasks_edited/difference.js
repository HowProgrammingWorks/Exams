'use strict';
const diff = (dictionary1, dictionary2) => {
  const differ = {};
  for (const index of Object.keys(dictionary1)) {
    differ[index] = dictionary1[index];
  }
  for (const index of Object.keys(dictionary2)) {
    if  (dictionary1[index] === dictionary2[index]) {
      delete differ[index];
    }
  }
  return dictionary2;
};
const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
