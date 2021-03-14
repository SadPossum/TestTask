<template>

  <v-card id="temp-card-class">

    <v-subheader>
      <v-btn id="temp-button-class" @click="loadData()"> Типа кнопка </v-btn>
    </v-subheader>

    <v-progress-circular
      id="temp-progress-circular-class"
      indeterminate
      v-if="dataLoading"
    />

    <v-list disabled>
      <v-list-item-group>
        <v-list-item v-for="(item, i) in items" :key="i">
          <v-list-item-content>
            <v-list-item-title v-text="item"></v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list-item-group>
    </v-list>

  </v-card>

</template>

<script>
import axios from "axios";

export default {
  data: () => ({
    selectedItem: 1,
    items: [],
    dataLoading: false
  }),

  methods: {
    loadData: async function () {
      this.dataLoading = true
      this.items = []

      await axios
        .get('http://localhost:5000/api/Values')
        .then(response => this.items = response.data)
        .catch(err => console.log(err));

      this.dataLoading = false
    },
  },
};
</script>

<style>
#temp-card-class {
  height: 300px;
  width: 500px;
  display: block;
  margin: auto;
}
#temp-progress-circular-class {
  display: block;
  margin: auto;
  top: 30%;
}
#temp-button-class {
  display: block;
  margin-left: 20px;
  margin-top: 20px;
}
</style>