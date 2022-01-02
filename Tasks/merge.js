// Merge two dictionaries
function mergeTwoDictionaries(first, second) {
  const mergedDic = {};
  for (const key in first) {
    mergedDic[key] = first[key];
  }
  for (const key in second) {
    mergedDic[key] = second[key];
  }
  return mergedDic;
}

const result = mergeTwoDictionaries({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
