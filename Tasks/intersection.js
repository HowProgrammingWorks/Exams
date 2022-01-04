// Finde an intersection of two dictionaries
'use strict'

const intersection = (first, second) => {
    const first_keys = Object.keys(first);
    const output = {};
    for (const attribute of first_keys) {
        if (attribute && first[attribute] === second[attribute])
            output[attribute] = first[attribute];
    }
    return output;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
