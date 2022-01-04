'use strict';
// Delete listed keys from dictionary

const drop = (dict, ...deleteKeys) => {
  const res = { ...dict };
  const dictKeys = Object.keys(dict);
  for (const key of dictKeys) {
    if (deleteKeys.includes(key)) {
      delete res[key];
    }
  }

  return res;
};

const result = drop({ a: 'uno', b: 'due', c: 'tre' }, 'b', 'f');
console.log(result);
