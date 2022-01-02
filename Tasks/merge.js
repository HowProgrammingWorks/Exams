// Merge two dictionaries
function mergeTwoDictionaries(first, second) {
  mergedDic = {};
  for (key in first) {
    mergedDic[key] == first[key];
    mergedDic[key] = first[key];
  }
  for (key in second) {
    mergedDic[key] == second[key];
    mergedDic[key] = second[key];
  }
  return first, second, mergedDic;
}

const result = mergeTwoDictionaries({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
