// Extract substring between prefix and suffix

getvaluebetween = (fullString, startString, endString) => {
  i = fullString.indexOf(startString);
  if (i === -1) return '';
  k = i + startString.length;
  fullString = fullString.substring(k);
  i = fullString.indexOf(endString);
  if (i === -1) return '';
  fullString = fullString.substring(0, i);
  return fullString;
};

require('../Tests/between.js')(getvaluebetween);
