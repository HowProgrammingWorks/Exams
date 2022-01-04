'use strict';

// Finde a difference of two dictionaries

const diff = (firstDict, secondDict) => {
  const diffDict = {};
  const keys = Object.keys(firstDict);
  for (const key of keys) {
    const value = firstDict[key];
    if (value !== secondDict[key]) diffDict[key] = firstDict[key];
  }
  return diffDict;
};

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
