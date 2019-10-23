
from django.urls import path
from geo import views

urlpatterns=[
    path(r'', views.index),
    path(r'getJson', views.getJson),
]