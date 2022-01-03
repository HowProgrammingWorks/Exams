// Find a difference of two dictionaries
'use strict';

const dictDifference = ({...obj1}, obj2) => {
  for (const key in obj2) {
    delete obj1[key];
  }
  return obj1;
};

const dict1 = { a: 'uno', b: 'due' };
const dict2 = { a: 'uno', c: 'tre' };
const result = dictDifference(dict1, dict2);
console.log({
  'dict1': dict1,
  'dict2': dict2,
  'dictionary difference': result
});