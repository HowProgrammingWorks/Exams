// Get month number

Months = [
  'jan',
  'feb',
  'mar',
  'apr',
  'may',
  'jun',
  'jul',
  'aug',
  'sep',
  'oct',
  'nov',
  'dec',
];

Month = (s) => {
  const month = s.toLowerCase().substring(0, 3);
  return Months.indexOf(month) !== -1 ? Months.indexOf(month) + 1 : -1;
};

require('../Tests/month.js')(Month);
