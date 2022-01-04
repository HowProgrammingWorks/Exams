// Finde an intersection of two dictionaries
'use strict'

const intersection = (first, second) => {
    const first_keys = Object.keys(first);
    for (const attribute of first_keys) {
        if (attribute !== '' && second[attribute])
            second[attribute] = first[attribute];
        else
            delete first[attribute];
    }
    return first;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
