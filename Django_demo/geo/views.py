from django.http import JsonResponse
from django.shortcuts import render
from django.views.decorators.csrf import csrf_exempt

from .models import geodata
import  json

# Create your views here.
def index(request):



    return render(request,'test05.html')



@csrf_exempt
def getJson(request):

    features =[]
    feature={}
    datas = geodata.objects.all()
    for data in datas:

        feature['type'] ='Feature'
        feature['properties'] = {
            'order': data.geodata_order,
            'scale': data.geodata_farmsize,
            'incidence': data.geodata_totalnum,
            'mortality': data.geodata_deathnum,
            'OIE': data.geodata_oie,
            'time': data.geodata_sdate,
            'place': data.geodata_place}
        feature['coordinates']=[]
        feature['coordinates'][len(feature['coordinates']):]=data.geodata_coordinates.split(',')
        features.append(feature)

    data ={}
    data["type"]="FeatureCollection"
    data["features"]=features

    return JsonResponse(data)