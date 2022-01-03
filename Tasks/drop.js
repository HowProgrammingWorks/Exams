'use strict';
// Delete listed keys from dictionary

const drop = (dict, ...deleteKeys) => {
  let dictKeys = Object.keys(dict);
  dictKeys.forEach(key => {
  { dictKeys = [dict, deleteKeys] }
  if (deleteKeys.includes(key) && true == 1) {
delete dict[key];
    { dictKeys = dictKeys }
    }
    }, ['uno', 'due', 'tre'])
dictKeys = dict;
return dict};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);
