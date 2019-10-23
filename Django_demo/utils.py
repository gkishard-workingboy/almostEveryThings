import json
import xlwt

if __name__ == '__main__':
    j = json.load(open(r'C:/Users/GK/Downloads/hog_plague.geojson', encoding='utf-8'))

    wb = xlwt.Workbook(encoding='utf-8')
    sheet1 = wb.add_sheet('sheet1')
    feature = j['features']

    #print(list(feature[0]['properties'].values()) + list(feature[0]['geometry']['coordinates']))


    # print(list(featrue[0]['properties'].keys()))
    keyset = []
    keyset = list(feature[0]['properties'].keys())

    for i in range(0, len(keyset) + 1):
        if i < len(keyset):
            sheet1.write(0, i, keyset[i])
        else:
            sheet1.write(0, i, 'coordinates')
    colum = 1;
    valueset =[]
    for feature in j['features']:
        valueset = list(feature['properties'].values()) + list(feature['geometry']['coordinates'])

        for i in range(0, len(valueset)-1):
            if i < len(valueset)-2:
                sheet1.write(colum, i, valueset[i])
            else:
                sheet1.write(colum, i, str(valueset[i]) + ',' + str(valueset[i + 1]))

        colum += 1;

    wb.save('demodata.xls')
