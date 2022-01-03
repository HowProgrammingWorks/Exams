// Delete listed keys from dictionary
'use strict';
const drop = (obj, ...keysToDrop) => {
    for (const keyObj in obj) {
        for (const key of keysToDrop) {
            if (keyObj === key) delete obj[keyObj];
        }
    }               
    return obj;
};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);
