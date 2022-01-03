'use strict';

// Finde a difference of two dictionaries

const diff = (firstDict, secondDict) => {
    const diffDict = {};
    for (const key in firstDict) {
        const value = firstDict[key];
        if (value !== secondDict[key]) diffObj[key] = firstDict[key];
    } 
    return diffDict;
}

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
