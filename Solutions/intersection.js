'use strict';

const intersection = (firstDictionary, secondDictionary) => {
    const firstKeys = Object.keys(firstDictionary);
    for (let key of firstKeys) {
        if ( !(key in secondDictionary) || firstDictionary[key] !== secondDictionary[key]) {
            delete firstDictionary[key];                                                                         
        }  
    }             
    return firstDictionary;
}

const result = intersection({ a: 'uno', b: 'due', c: 'tre'}, { a: 'uno', c: 'tre' });
console.log(result);
