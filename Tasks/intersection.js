// Finde an intersection of two dictionaries

const intersection = function intersection (object1,object2) {
    const resObject = {};
    for (const key in object1) {
        if (object1[key] === object2[key]) {
            resObject[key] = object1[key];
        }
    }
return resObject;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
