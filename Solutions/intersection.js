'use strict';

const intersection = (firstDictionary, secondDictionary) => {
  const firstKeys = Object.keys(firstDictionary);
  let resultDictionary = {};
  for (let key of firstKeys) {
    if (key in secondDictionary && firstDictionary[key] === secondDictionary[key]) {
      resultDictionary[key] = firstDictionary[key]                                                                         
    }  
  }             
  return resultDictionary;
};

const result = intersection({ a: 'uno', b: 'due', c: 'tre'}, { a: 'uno', c: 'tre' });
console.log(result);
