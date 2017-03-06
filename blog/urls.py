from django.conf.urls import include, url
from . import views

urlpatterns = [
    url(r'^$', views.publicacion_list),
    url(r'^publicacion/(?P<pk>[0-9]+)/$', views.publicacion_detalle),
    url(r'^publicacion/crear/$', views.publicacion_crear, name='publicacion_crear'),
    url(r'^markov/steps/$', views.markov_steps)
]