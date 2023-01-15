// Return an array without duplicates
'use strict';

const duplicate = (value, amount) => {
    const array = [];
    for (let i = 0; i < amount; i++)
      array[i] = value;
    return array;
};

require('../Tests/duplicate.js')(duplicate);
