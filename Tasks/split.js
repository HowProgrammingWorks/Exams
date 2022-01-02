// Split array into two parts
'use strict';

const splitArray = (index, array) => {
    const begin = array.slice(0, index);
    array = array.slice(index, array.length);
    return [begin, array];
}

const result = splitArray(3, ['a', 'b', 'c', 'd', 'e']);
console.log(result);
