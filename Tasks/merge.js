// Merge two dictionaries
'use strict';
function mergeTwoDictionaries(first, second) {
  return { ...first, ...second };
}

const result = mergeTwoDictionaries({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
