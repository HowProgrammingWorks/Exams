// Extract substring between prefix and suffix

getvaluebetween = (fullString, startString, endString) => {
  if (fullString.indexOf(startString) === -1) return '';
  fullString = fullString.substring(fullString.indexOf(startString) + startString.length);
  if (fullString.indexOf(endString) === -1) return '';
  fullString = fullString.substring(0, fullString.indexOf(endString));
  return fullString;
};

require('../Tests/between.js')(getvaluebetween);
