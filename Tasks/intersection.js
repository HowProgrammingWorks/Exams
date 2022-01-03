// Finde an intersection of two dictionaries

const intersection = function intersection (object1,object2) {
    for (const key in object1) {
        if (key !== '' && object2[key]) {
            object2[key] = object1[key];
        }
        else {
            delete object1[key];
        }
    }
return object1;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
