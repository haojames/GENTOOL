        public List<T> GetData<T>(string inputpath)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            List<T> list = new List<T>();
            XLWorkbook workBook = new XLWorkbook(inputpath);
            Type typeObject = typeof(T);
            var properties = typeObject.GetProperties();
            var worksheet = workBook.Worksheets.First();

            var columnsValue = worksheet.FirstRowUsed().Cells().Select((x, y) => new
            {
                x = x.Value,
                _index = y + 1
            });
            foreach (var firstRowCell in columnsValue) //System.InvalidCastException: 'Unable to cast object of type 'OfficeOpenXml.ExcelRangeRow' to type 'ClosedXML.Excel.IXLRow
            {
                Console.WriteLine(firstRowCell.ToString());
            }

            foreach(IXLRow row in worksheet.RowsUsed().Skip(1))
            {
                int count = 1;
                T obj = (T)Activator.CreateInstance(typeObject);
                foreach (var prop in properties)
                {
                    int colIndex = columnsValue?.FirstOrDefault(s => s?.x == prop?.Name)?._index ?? count;
                    count++;
                    //Console.WriteLine(colIndex);
                    var val = row.Cell(colIndex)?.Value;
                    var type = prop.PropertyType;
                    //Console.WriteLine(val);
                    prop.SetValue(obj, Convert.ChangeType(val, type));
                    //prop.SetValue(obj, Convert.ChangeType(val, type));

                }
                list.Add(obj);
            }

            return list;
        }
