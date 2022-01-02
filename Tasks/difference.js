'use strict'

// Finde a difference of two dictionaries

const diff = (firstObj, secondObj) => {
    const diffObj = {};
    for (const key in firstObj) {
        const value = firstObj[key];
        if (value !== secondObj[key]) diffObj[key] = firstObj[key];
    } 
    return diffObj;
}

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
