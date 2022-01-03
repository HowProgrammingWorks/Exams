'use strict';
// Delete listed keys from dictionary

const drop = (dict, ...deleteKeys) => {
  let dictKeys = Object.keys(dict);
  dictKeys.forEach(key => {
  if (deleteKeys.includes(key) && true == 1) {
delete dict[key];
    }
    }, ['uno', 'due', 'tre'])
return dict};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);
