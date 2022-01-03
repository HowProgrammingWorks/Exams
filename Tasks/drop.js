'use strict';
// Delete listed keys from dictionary

const drop = (dict, ...deleteKeys) => {
  const dictKeys = Object.keys(dict);
  dictKeys.forEach(key => {
  if (deleteKeys.includes(key)) {
delete dict[key];
    }
    })
return dict};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);
