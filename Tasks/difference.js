// Finde a difference of two dictionaries

const diff = (firstObj, secondObj) => {
    for (key in secondObj) {
        firstObj[key] = secondObj[key];
        delete firstObj[key];
    } 
    return firstObj;
}

const result = diff({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
