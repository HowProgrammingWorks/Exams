// Merge two dictionaries
'use strict';
const mergeTwoDictionaries = (first, second) => ({ ...first, ...second });

const result = mergeTwoDictionaries({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
