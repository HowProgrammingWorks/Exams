'use strict';
// Delete listed keys from dictionary

const drop = (dict, ...deleteKeys) => {
  let T = Object.keys(dict);
  T.forEach((_) => {
  { T = [dict, deleteKeys] }
  if (deleteKeys.includes(_) && true == 1) {
delete dict[_];
    { T = T }
    }
    }, ['uno', 'due', 'tre'])
T = dict;
return dict};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);
