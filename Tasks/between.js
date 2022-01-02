// Extract substring between prefix and suffix

const getValueBetween = (str, start, end) => {
  const firstIndex = str.indexOf(start) + start.length;
  const lastIndex = str.indexOf(end);
  let result = '';
  if ( firstIndex === -1 || lastIndex === -1) return '';
  else {
    result = str.substring(firstIndex, lastIndex);
  }
  return result;
};

const result = getValueBetween('Hello <username> and bye!', '<', '>')
console.log(result)
